import { Component, OnInit } from '@angular/core';
import { FavouritesService } from '../service/favourites.service';
import { GetFavouritesProducts } from '../models/get-favourites.model';
import { UserService } from '../../user/service/user.service';
import { FavouriteProducts } from '../models/favourite-products.model';
import { AddItemToBasket } from '../../basket/models/add-item.model';
import { BasketService } from '../../basket/service/basket.service';

@Component({
  selector: 'app-favourites',
  templateUrl: './favourites.component.html',
  styleUrls: ['./favourites.component.css']
})
export class FavouritesComponent implements OnInit {

  userId: number;
  products: FavouriteProducts[] = [];
  addItemModel: AddItemToBasket;
  showForm: boolean[] = [];

  constructor(private favouriteService: FavouritesService, private userService: UserService, private basketService: BasketService){
    debugger;
    this.userId = userService.getUserData().id;

    this.addItemModel = {
      basketId: this.basketService.getBasketId().basketId,
      productId: 0,
      quantity: 1
    }
  }
  ngOnInit(): void {
    this.getFavouritesItems();
  }

  getFavouritesItems(){
    this.favouriteService.getFavouritesItems(this.userId)
    .subscribe(products => this.products = products);
  }

  addToBasket(productId: number, index: number){
    this.addItemModel.productId = productId;
    this.basketService.addItemToBasket(this.addItemModel).subscribe({
      next: (response) => console.log("Item was added"),
      error: (err) => console.error("Error: ", err)
    });
    this.cancel(index);
  }

  showQuantityForm(index: number): void{
    debugger;
    this.showForm[index] = true;
  }

  cancel(index: number): void{
    this.showForm[index] = false;
  }
}
