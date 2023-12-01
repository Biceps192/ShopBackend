import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../products/services/product.service';
import { BasketService } from '../service/basket.service';
import { ProductsByBasketId } from '../../products/models/product-by-basketId.model';
import { CreateBasketRequest } from '../models/create-basket.model';
import { BasketReadModel } from '../models/basket-read.model';

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

  constructor(private productService: ProductService, private basketService: BasketService){
    this.basket = basketService.getBasketId();
    this.basketId = this.basket.basketId;

    this.price = {
      price: 0
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
}
