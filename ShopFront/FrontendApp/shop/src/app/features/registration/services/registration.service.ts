import { Injectable } from '@angular/core';
import { AddUserRequest } from '../models/add-user-request.model';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { UserReadRequest } from '../models/user-read-request.model';

@Injectable({
  providedIn: 'root'
})
export class RegistrationService {

  constructor(private http: HttpClient) {

   }

   addUser(model: AddUserRequest): Observable<void>{
    return this.http.post<void>('https://localhost:7093/api/Authentication/register', model)
   } 

//    getUsers(model: UserReadRequest): Observable<ArrayBuffer>{
//     return this.http.get<ArrayBuffer>('https://localhost:7093/', model)
//    }
}
