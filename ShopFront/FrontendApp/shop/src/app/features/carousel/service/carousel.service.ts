import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CarouselReadModel } from '../model/read-carousel.model';

@Injectable({
  providedIn: 'root'
})
export class CarouselService {
  private readonly subcategoryId = 'subcategoryId';
  model: CarouselReadModel[] = [];

  constructor(private http: HttpClient) { }

  getSubcategoriesByCategory(id: number): Observable<CarouselReadModel[]>{
    return this.http.get<CarouselReadModel[]>(`https://localhost:7093/GetAllSubcategoriesByCategory?id=${id}`);
  }

  getSubcategoryId(): any{
    const subcategoryId = localStorage.getItem(this.subcategoryId);
    return subcategoryId ? JSON.parse(subcategoryId): null;  
  }

  setSubcategory(subcategory: any): void{
    debugger;
    localStorage.setItem(this.subcategoryId, JSON.stringify(subcategory));
    console.log('Subcategory saved: ', subcategory);
  }
}
