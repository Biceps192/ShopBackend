import { Component, OnInit } from '@angular/core';
import { CarouselReadModel } from '../../carousel/model/read-carousel.model';
import { ProductService } from '../../products/services/product.service';
import { CategoryService } from '../services/category.service';
import { CarouselService } from '../../carousel/service/carousel.service';
import { BasketService } from '../../basket/service/basket.service';
import { AddItemToBasket } from '../../basket/models/add-item.model';
import { ProductReadModel } from '../../products/models/product-read.model';

@Component({
  selector: 'app-subcategory',
  templateUrl: './subcategory.component.html',
  styleUrls: ['./subcategory.component.css']
})
export class SubcategoryComponent implements OnInit {
  subcategory: CarouselReadModel;
  subcategoryId: number;
  addItemModel: AddItemToBasket;
  showForm: boolean[] = [];
  products: ProductReadModel[] = [];

  constructor(private productService: ProductService, private carouselService: CarouselService, private basketService: BasketService){
    this.subcategory = this.carouselService.getSubcategoryId();
    this.subcategoryId = this.subcategory.id;

    this.addItemModel ={
      productId: 0,
      basketId: this.basketService.getBasketId().basketId,
      quantity: 1
    }
  }

  ngOnInit(){
    this.getProductsBySubcategory();
  }

  getProductsBySubcategory(){
    debugger;
    this.productService.getProductsBySubcategory(this.subcategoryId).subscribe(
      products => this.products = products
    );
  }

  addItemToBasket(){
    debugger;
    this.basketService.addItemToBasket(this.addItemModel).subscribe({
      next: (response) => console.log('Item added'),
      error: (err) => console.error('Error: ', err)
    });
  }

  basketStatusTrue(productId: number, index: number){
    debugger;
    this.addItemModel.productId = productId;    
    this.addItemToBasket();
    this.basketService.setBasketStatus(true);
    this.addItemModel.quantity = 1;
    this.cancel(index);
  }

  showQuantityForm(index: number): void{
    this.showForm[index] = true;
  }

  cancel(index: number): void{
    this.showForm[index] = false;
  }
}
