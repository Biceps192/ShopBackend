import { Component, OnInit } from '@angular/core';
import { BasketService } from 'src/app/features/basket/service/basket.service';
import { LoginModel } from 'src/app/features/login/models/login.model';
import { LoginService } from 'src/app/features/login/service/login.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  basketStatus: boolean = false;

  constructor(private basketService: BasketService, public loginService: LoginService){

  }

  ngOnInit(): void {
    this.basketService.getBasketStatus().subscribe(status => {
      this.basketStatus = status;
    })
  }


}
