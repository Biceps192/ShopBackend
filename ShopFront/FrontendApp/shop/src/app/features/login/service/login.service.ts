import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, tap } from 'rxjs';
import { AuthToken } from '../models/authtoken.model';
import { UserId } from '../models/user-id.model';
import { UserSave } from '../models/save-user.model';
import { UserService } from '../../user/service/user.service';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  authToken: AuthToken;
  saveUserId: UserSave;

  constructor(private http: HttpClient, private userService: UserService) {
    this.authToken = {
      authToken: ''
    }

    this.saveUserId ={
      id: 0
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
          this.saveUserId.id = response.id;
          localStorage.setItem('authToken', this.authToken.authToken);
          this.userService.saveUserData(this.saveUserId);
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
