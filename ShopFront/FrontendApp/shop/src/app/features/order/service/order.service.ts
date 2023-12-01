import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CreateOrder } from '../models/create-order.model';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  constructor(private http: HttpClient) {

   }

  createOrder(model: CreateOrder) :Observable<any>{
    return this.http.post<any>('https://localhost:7093/api/Order/CreateOrder', model);
  }
}
