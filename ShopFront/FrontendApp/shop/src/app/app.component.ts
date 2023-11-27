import { Component, OnInit } from '@angular/core';
import { BasketService } from './features/basket/service/basket.service';
import { UserService } from './features/user/service/user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'shop';

  userStatus: any;

  constructor(private basketService: BasketService, private userService: UserService){

  }
  ngOnInit(): void {
    if(this.userService.getUserData() != null){
      this.setBasketStatus(true);
    }
  }
  
  setBasketStatus(status: boolean){
    this.basketService.setBasketStatus(status);
  }

  getUserStatus(){
    this.userStatus = this.userService.getUserData();
  }
}
