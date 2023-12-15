import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { ProductReadModel } from '../models/product-read.model';
import { ProductsByBasketId } from '../models/product-by-basketId.model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http: HttpClient) {

   }

  getProductsByCategory(id:number, page: number, pageSize: number): Observable<ProductReadModel[]>{
    return this.http.get<ProductReadModel[]>(`https://localhost:7093/api/Product/GetByCategory?id=${id}&page=${page}&pageSize=${pageSize}`);
  }

  getProductsByBasketId(id: number): Observable<ProductsByBasketId[]>{
    return this.http.get<ProductsByBasketId[]>(`https://localhost:7093/api/Product/GetAllProductsByBasketId?basketId=${id}`);
  }
  
  getProductById(id: number): Observable<ProductReadModel[]>{
    return this.http.get<ProductReadModel[]>(`https://localhost:7093/api/Product/${id}`);
  }

  getProductsBySubcategory(id: number): Observable<ProductReadModel[]>{
    return this.http.get<ProductReadModel[]>(`https://localhost:7093/api/Product/GetProductsBySubcategoryId?subcategoryId=${id}`);
  }

  getAllProducts(): Observable<ProductReadModel[]>{
    return this.http.get<ProductReadModel[]>('https://localhost:7093/api/Product');
  }
  
  getCount(id: number): Observable<number>{
    return this.http.get<number>(`https://localhost:7093/api/Product/GetCountOfProducts?id=${id}`);
  }
}
