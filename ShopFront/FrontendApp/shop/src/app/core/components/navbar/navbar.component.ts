import { Component, OnInit } from '@angular/core';
import { BasketService } from 'src/app/features/basket/service/basket.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  basketStatus: boolean = false;

  constructor(private basketService: BasketService){

  }

  ngOnInit(): void {
    this.basketService.getBasketStatus().subscribe(status => {
      this.basketStatus = status;
    })
  }


}
