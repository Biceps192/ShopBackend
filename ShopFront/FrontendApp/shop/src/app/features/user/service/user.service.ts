import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AddPublicUserRequest } from '../models/user-request.model';
import { Observable, map } from 'rxjs';
import { PublicUserRead } from '../models/user-read.model';
import { CreateBasketRequest } from '../../basket/models/create-basket.model';
import { BasketService } from '../../basket/service/basket.service';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private readonly publicUserKey = 'PublicUserData';
  private readonly userKey = 'UserData';
  basket: CreateBasketRequest;
  userId: number;

  constructor(private http: HttpClient, private basketService: BasketService) { 
    this.basket = basketService.getBasketId();
    this.userId = this.basket.publicUserId;
  }

  addPublicUser(model: AddPublicUserRequest): Observable<any>{
    return this.http.post<any>('https://localhost:7093/api/User', model)
  }

  savePublicUserData(userData: any): void{
    localStorage.setItem(this.publicUserKey, JSON.stringify(userData));
    console.log('Data saved: ', userData);
  }  

  getPublicUserData(): any{
    const userDataString = localStorage.getItem(this.publicUserKey);
    return userDataString ? JSON.parse(userDataString): null;  
  }

  saveUserData(userData: any){
    localStorage.setItem(this.userKey, JSON.stringify(userData));
    console.log('User saved: ', userData)
  }

  getUserData(){
    const userDataString = localStorage.getItem(this.userKey);
    return userDataString ? JSON.parse(userDataString): null;
  }
  
}
