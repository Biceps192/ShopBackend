import { Component, OnInit, OnDestroy, OnChanges } from '@angular/core';
import { CategoryReadModel } from '../models/category-read.model';
import { CategoryService } from '../services/category.service';
import { ProductService } from '../../products/services/product.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-categories-list',
  templateUrl: './categories-list.component.html',
  styleUrls: ['./categories-list.component.css']
})
export class CategoriesListComponent implements OnInit, OnChanges {
  model: CategoryReadModel[] = [];

  constructor(private categoryService: CategoryService, private router: Router){
    }

  ngOnInit(): void {
    this.onGet();
  }

  ngOnChanges(): void{
    this.selectCategory;
  }


  onGet(){
    this.categoryService.getCategories()
    .subscribe(model => this.model = model);
  }

  selectCategory(categoryId: number){
    this.categoryService.setId(categoryId);
  }
}





