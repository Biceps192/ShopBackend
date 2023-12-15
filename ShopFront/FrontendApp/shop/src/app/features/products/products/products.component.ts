import { Type } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CategoriesListComponent } from '../../category/categories-list/categories-list.component';
import { CategoryService } from '../../category/services/category.service';
import { ProductReadModel } from '../models/product-read.model';
import { ProductService } from '../services/product.service';
import { BasketService } from '../../basket/service/basket.service';
import { AddItemToBasket } from '../../basket/models/add-item.model';
import { FavouritesComponent } from '../../favourites/favourites/favourites.component';
import { FavouritesService } from '../../favourites/service/favourites.service';
import { AddToFavourite } from '../../favourites/models/add-to-favourite.model';
import { CreateBasketRequest } from '../../basket/models/create-basket.model';
import { UserService } from '../../user/service/user.service';
import { LoginService } from '../../login/service/login.service';
import { PageEvent } from '@angular/material/paginator';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  categoryId: number;
  selectedComponent: any;
  products: ProductReadModel[] = [];
  basketStatus: boolean = false;
  addItemModel: AddItemToBasket;
  showForm: boolean[] = [];
  addToFavouriteModel: AddToFavourite;
  basket: CreateBasketRequest;
  publicUserId: number;
  currentPage = 0;
  pageSize = 2;
  totalCount: number;

  constructor( private route: ActivatedRoute, 
    private categoryService: CategoryService, 
    private productService: ProductService, 
    private basketService: BasketService,
    private favouriteService: FavouritesService,
    private userService: UserService,
    public loginService: LoginService){
    this.categoryId = 1;

    this.basket = basketService.getBasketId();
    this.publicUserId = this.basket.publicUserId;

    this.addItemModel = {
      productId: 0,
      basketId: this.basketService.getBasketId().basketId,
      quantity: 1
    }

    this.addToFavouriteModel = {
      userId: userService.getUserData().id,
      productId: 0
    }

    this.totalCount = 1;
  }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.categoryId = +params['id'];
    })
    this.getItems();
    this.getCount(this.categoryId);
    this.basketService.getBasketStatus().subscribe(status => {
      this.basketStatus = status;
    })
  }

  getItems(){
    this.productService.getProductsByCategory(this.categoryId, this.currentPage, this.pageSize)
    .subscribe((products) => {
      this.products = products;
    });
  }

  getCount(id: number){
    this.productService.getCount(id).subscribe((response) => {
      this.totalCount = response;
    });
  }

  basketStatusTrue(productId: number, index: number){
    this.addItemModel.productId = productId;    
    this.addItemToBasket();
    this.basketService.setBasketStatus(true);
    this.addItemModel.quantity = 1;
    this.cancel(index);
  }

  addItemToBasket(){
    this.basketService.addItemToBasket(this.addItemModel).subscribe({
      next: (response) => console.log('Item added'),
      error: (err) => console.error('Error: ', err)
    });
  }

  showQuantityForm(index: number): void{
    this.showForm[index] = true;
  }

  cancel(index: number): void{
    this.showForm[index] = false;
  }

  addToFavourites(productId: number){
    this.addToFavouriteModel.productId = productId;
    this.favouriteService.addToFavourite(this.addToFavouriteModel).subscribe({
      next: (response) => console.log('Item was added to favourite'),
      error: (err) => console.error('Error: ', err)
    });
  }

  handlePageEvent(page: PageEvent){
    debugger;
    this.currentPage = page.pageIndex;
    console.log(this.currentPage);
    this.getItems();
  }
}
