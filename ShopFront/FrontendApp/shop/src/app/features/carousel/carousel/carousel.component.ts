import { Component, OnInit } from '@angular/core';
import { CarouselService } from '../service/carousel.service';
import { CarouselReadModel } from '../model/read-carousel.model';
import { OwlOptions } from 'ngx-owl-carousel-o';
import { CategoryService } from '../../category/services/category.service';
import { ActivatedRoute, Router, RouterEvent } from '@angular/router';

@Component({
  selector: 'app-carousel',
  templateUrl: './carousel.component.html',
  styleUrls: ['./carousel.component.css']
})
export class CarouselComponent implements OnInit {

  model: CarouselReadModel[] = [];
  categoryId: number ;

  constructor(private carouselService: CarouselService, private categoryService: CategoryService, private route: ActivatedRoute){
    this.categoryId = 0;
  }


  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.categoryId = +params['id'];
    })
    this.onGetSubcategories(this.categoryId);
  }

  onGetSubcategories(categoryId: number){
    this.carouselService.getSubcategoriesByCategory(categoryId).
    subscribe(model => this.model = model);
  }
  
  customOptions: OwlOptions = {
    items: 4,
    loop: true,
    mouseDrag: true,
    touchDrag: false,
    pullDrag: false,
    dots: false,
    navSpeed: 1000,
    margin: 10,
    navText: ['', ''],
    nav: true
  }

}
