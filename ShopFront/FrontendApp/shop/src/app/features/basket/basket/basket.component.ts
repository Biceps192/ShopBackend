import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../products/services/product.service';
import { BasketService } from '../service/basket.service';
import { ProductsByBasketId } from '../../products/models/product-by-basketId.model';
import { CreateBasketRequest } from '../models/create-basket.model';

@Component({
  selector: 'app-basket',
  templateUrl: './basket.component.html',
  styleUrls: ['./basket.component.css']
})
export class BasketComponent implements OnInit {
  basket: CreateBasketRequest;
  basketId: number;
  products: ProductsByBasketId[] =[];

  constructor(private productService: ProductService, private basketService: BasketService){
    this.basket = basketService.getBasketId();
    this.basketId = this.basket.basketId;
  }
  ngOnInit(): void {
    this.getProductsByBasketId();
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
}
