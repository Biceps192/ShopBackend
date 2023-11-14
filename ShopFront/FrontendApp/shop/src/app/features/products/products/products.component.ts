import { Type } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CategoriesListComponent } from '../../category/categories-list/categories-list.component';
import { CategoryService } from '../../category/services/category.service';
import { ProductReadModel } from '../models/product-read.model';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  categoryId: number;
  selectedComponent: any;
  products: ProductReadModel[] = [];

  constructor( private route: ActivatedRoute, private categoryService: CategoryService, private productService: ProductService){
    this.categoryId = 1;
  }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.categoryId = +params['id'];
    })
    this.getItems();
  }

  getItems(){
    this.productService.getProductsByCategory(this.categoryId)
    .subscribe(products => this.products = products);
    debugger;
  }

}
