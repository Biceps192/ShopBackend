import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, tap } from 'rxjs';
import { AuthToken } from '../models/authtoken.model';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  authToken: AuthToken;

  constructor(private http: HttpClient) {
    this.authToken = {
      authToken: ''
    }
   }

   login(email: string, password: string): Observable<any>{
    debugger;
    const credentials ={
      email: email,
      password: password
    }

    return this.http.post<any>('https://localhost:7093/api/Authentication/login', credentials).pipe(
      tap(response => {
        debugger;
        if(response && response.authToken){
          debugger;
          this.authToken.authToken = response.authToken;
          localStorage.setItem('authToken', this.authToken.authToken);
        }
      })
    );
   }

   getAuthToken(): string{
    return this.authToken.authToken;
   }

   isLoggedIn(): boolean{
    return !!localStorage.getItem('authToken');
   }

   logout(){
    this.authToken.authToken = '';
    localStorage.removeItem('authToken');
   }
}
