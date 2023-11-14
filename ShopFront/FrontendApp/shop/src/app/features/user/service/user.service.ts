import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AddPublicUserRequest } from '../models/user-request.model';
import { Observable } from 'rxjs';
import { PublicUserRead } from '../models/user-read.model';
import { CreateBasketRequest } from '../../basket/models/create-basket.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { 
    
  }

  addPublicUser(model: AddPublicUserRequest): Observable<CreateBasketRequest[]>{
    return this.http.post<CreateBasketRequest[]>('https://localhost:7093/api/User', model);
  }

  getPublicUserByEmail(){

  }
}
