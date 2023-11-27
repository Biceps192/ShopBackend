import { Type } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CategoriesListComponent } from '../../category/categories-list/categories-list.component';
import { CategoryService } from '../../category/services/category.service';
import { ProductReadModel } from '../models/product-read.model';
import { ProductService } from '../services/product.service';
import { BasketService } from '../../basket/service/basket.service';
import { AddItemToBasket } from '../../basket/models/add-item.model';

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

  constructor( private route: ActivatedRoute, private categoryService: CategoryService, private productService: ProductService, private basketService: BasketService){
    this.categoryId = 1;

    this.addItemModel = {
      productId: 0,
      basketId: this.basketService.getBasketId().basketId
    }
  }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.categoryId = +params['id'];
    })
    this.getItems();
    this.basketService.getBasketStatus().subscribe(status => {
      this.basketStatus = status;
    })
  }

  getItems(){
    this.productService.getProductsByCategory(this.categoryId)
    .subscribe(products => this.products = products);
  }

  basketStatusTrue(productId: number){
    this.addItemModel.productId = productId;    
    this.basketService.addItemToBasket(this.addItemModel).subscribe({
      next: (response) => console.log('Item added'),
      error: (err) => console.error('Error: ', err)
    });
    this.basketService.setBasketStatus(true);
  }

}
