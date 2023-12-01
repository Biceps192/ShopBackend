import { Component, OnInit } from '@angular/core';
import { OrderService } from '../service/order.service';
import { BasketService } from '../../basket/service/basket.service';
import { ProductService } from '../../products/services/product.service';
import { ProductReadModel } from '../../products/models/product-read.model';
import { ProductsByBasketId } from '../../products/models/product-by-basketId.model';
import { BasketReadModel } from '../../basket/models/basket-read.model';
import { CreateBasketRequest } from '../../basket/models/create-basket.model';

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {
  basket: CreateBasketRequest;
  products: ProductsByBasketId[] = [];
  price: BasketReadModel;
  basketId: number;

  constructor(private orderService: OrderService, private basketService: BasketService, private productService: ProductService){
    this.basket = basketService.getBasketId();
    this.basketId = this.basket.basketId;
    
    this.price = {
      price: 0
    }
  }

  ngOnInit() {
    this.getBasket();
    this.getBasketPrice();
  }

  getBasket(){
    this.productService.getProductsByBasketId(this.basketId).subscribe(products => this.products = products);
  }

  getBasketPrice(){
    if(this.price.price == 0){
      this.basketService.getBasketPrice(this.basketId).subscribe(price => this.price = price);
    }
    return this.price;
  }

}
