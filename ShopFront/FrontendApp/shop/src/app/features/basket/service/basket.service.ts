import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { BasketRequsetModel } from '../models/basket-request.model';
import { CreateBasketRequest } from '../models/create-basket.model';

@Injectable({
  providedIn: 'root'
})
export class BasketService {
  private basketStatusSubject: BehaviorSubject<boolean> = new BehaviorSubject<boolean>(false);
  
  constructor(private http: HttpClient) { 
  }

  // itemInBasket(): Observable<void>{
  //   this.http.post('',)
  // }

  createBasket(model: CreateBasketRequest): Observable<void>{
    return this.http.post<void>('https://localhost:7093/api/Basket/CreateBasket', model);
  }

  getBasketStatus(): Observable<boolean>{
    return this.basketStatusSubject.asObservable();
  }

  setBasketStatus(status: boolean): void{
    this.basketStatusSubject.next(status);
  }

}
