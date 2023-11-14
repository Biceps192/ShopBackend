import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { ProductReadModel } from '../models/product-read.model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http: HttpClient) { }

  getProductsByCategory(id:number): Observable<ProductReadModel[]>{
    return this.http.get<ProductReadModel[]>(`https://localhost:7093/api/Product/GetByCategory?id=${id}`);
  }
}