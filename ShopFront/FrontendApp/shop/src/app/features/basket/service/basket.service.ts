import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { CreateBasketRequest } from '../models/create-basket.model';
import { AddItemToBasket } from '../models/add-item.model';

@Injectable({
  providedIn: 'root'
})
export class BasketService {
  private basketStatusSubject: BehaviorSubject<boolean> = new BehaviorSubject<boolean>(false);
  private readonly basketKey = 'basket';
  private readonly basketIdKey = 'basketId';
  
  constructor(private http: HttpClient) { 
  }

  addItemToBasket(model: AddItemToBasket): Observable<void>{
    return this.http.post<void>('https://localhost:7093/api/Basket/AddItemToBasket', model);
  }

  createBasket(model: CreateBasketRequest): Observable<any>{
    return this.http.post<any>('https://localhost:7093/api/Basket/CreateBasket', model);
  }

  getBasketStatus(): Observable<boolean>{
    return this.basketStatusSubject.asObservable();
  }

  setBasketStatus(status: boolean): void{
    this.basketStatusSubject.next(status);
  }

  saveBasket(basket: any): void{
    localStorage.setItem(this.basketKey, JSON.stringify(basket));
    console.log('Basket saved: ', basket);
  }  

  getBasketId(): any{
    const basketId = localStorage.getItem(this.basketKey);
    return basketId ? JSON.parse(basketId): null;  
  }

}
