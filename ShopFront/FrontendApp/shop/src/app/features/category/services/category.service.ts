import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CategoryReadModel } from '../models/category-read.model';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  selectedCategoryId: number;

  constructor(private http: HttpClient) { 
    this.selectedCategoryId = 0;
  }

  getCategories(): Observable<CategoryReadModel[]>{
    return this.http.get<CategoryReadModel[]>('https://localhost:7093/api/Category');
  }

  getId(){
    return this.selectedCategoryId
  }

  setId(id: number){
    this.selectedCategoryId = id;
  }
}
