import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AddPublicUserRequest } from '../models/user-request.model';
import { Observable, map } from 'rxjs';
import { PublicUserRead } from '../models/user-read.model';
import { CreateBasketRequest } from '../../basket/models/create-basket.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private readonly userKey = 'userData';

  constructor(private http: HttpClient) { 
    
  }

  addPublicUser(model: AddPublicUserRequest): Observable<any>{
    return this.http.post<any>('https://localhost:7093/api/User', model)
  }

  saveUserData(userData: any): void{
    localStorage.setItem(this.userKey, JSON.stringify(userData));
  }  

  getUserData(): any{
    const userDataString = localStorage.getItem(this.userKey);
    return userDataString ? JSON.parse(userDataString): null;  
  }
  
}
