import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CarouselReadModel } from '../model/read-carousel.model';

@Injectable({
  providedIn: 'root'
})
export class CarouselService {

  model: CarouselReadModel[] = [];

  constructor(private http: HttpClient) { }

  getSubcategoriesByCategory(id: number): Observable<CarouselReadModel[]>{
    return this.http.get<CarouselReadModel[]>(`https://localhost:7093/GetAllSubcategoriesByCategory?id=${id}`);
  }
}
