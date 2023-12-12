import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AddToFavourite } from '../models/add-to-favourite.model';
import { Observable } from 'rxjs';
import { GetFavouritesProducts } from '../models/get-favourites.model';

@Injectable({
  providedIn: 'root'
})
export class FavouritesService {

  constructor(private http: HttpClient) {

   }

   addToFavourite(model: AddToFavourite): Observable<any>{
    return this.http.post<any>('https://localhost:7093/api/Product/AddToFavourite',model);
   }

   getFavouritesItems(userId: number): Observable<any>{
    return this.http.get<any>(`https://localhost:7093/api/Product/GetFavouritesProductsByUserId?userId=${userId}`);
   }
}
