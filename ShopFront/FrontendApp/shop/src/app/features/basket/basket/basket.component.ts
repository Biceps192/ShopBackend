import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../products/services/product.service';
import { BasketService } from '../service/basket.service';
import { ProductsByBasketId } from '../../products/models/product-by-basketId.model';
import { CreateBasketRequest } from '../models/create-basket.model';
import { BasketReadModel } from '../models/basket-read.model';
import { AddItemToBasket } from '../models/add-item.model';

@Component({
  selector: 'app-basket',
  templateUrl: './basket.component.html',
  styleUrls: ['./basket.component.css']
})
export class BasketComponent implements OnInit {
  basket: CreateBasketRequest;
  basketId: number;
  products: ProductsByBasketId[] =[];
  price: BasketReadModel;
  showForm: boolean[] = [];
  deleteItem: AddItemToBasket;

  constructor(private productService: ProductService, private basketService: BasketService){
    this.basket = basketService.getBasketId();
    this.basketId = this.basket.basketId;

    this.price = {
      price: 0
    }

    this.deleteItem ={
      basketId: this.basketId,
      productId: 0,
      quantity: 0
    }
  }
  ngOnInit(): void {
    this.getProductsByBasketId();
    this.getBasketPrice(this.basketId);
  }

  getProductsByBasketId(){
    this.productService.getProductsByBasketId(this.basketId)
    .subscribe(products => this.products = products);
  }

  calculateTotal(): number{
    let total = 0;
    for(const item of this.products){
      total += item.price
    }

    return total;
  }

  getBasketPrice(basketId: number){
    if(this.price.price == 0){
      this.basketService.getBasketPrice(basketId).subscribe(price => this.price = price);
    }
    return this.price;
  }

  removeItemsFromBasket(productId: number, index: number){
    debugger;
    this.showQuantityForm(index);
    this.deleteItem.productId = productId;
    this.basketService.deleteItemFromBasket(this.deleteItem).subscribe({
      next: (response) => console.log('Item deleted'),
      error: (err) => console.error('Error: ', err)
    });
    this.hideQuantityForm(index);
  }

  showQuantityForm(index: number){
    this.showForm[index] = true;
  }

  hideQuantityForm(index: number){
    this.showForm[index] = false;
  }
}
