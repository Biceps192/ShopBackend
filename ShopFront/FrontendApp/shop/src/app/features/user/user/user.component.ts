import { Component } from '@angular/core';
import { UserService } from '../service/user.service';
import { AddPublicUserRequest } from '../models/user-request.model';
import { CreateBasketRequest } from '../../basket/models/create-basket.model';
import { BasketService } from '../../basket/service/basket.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent {
  model: AddPublicUserRequest;
  createBasketRequest: CreateBasketRequest

  constructor(private publicUserService: UserService, private basketService: BasketService){
    this.model = {
      firstName: '',
      lastName: '',
      email: '',
      phoneNumber: ''
    }

    this.createBasketRequest = {
      publicUserId: 0
    }
  }

  onSubmit(){
    this.publicUserService.addPublicUser(this.model).subscribe({
      next: (response) => {console.log('User Add')},
      error: (err) => {console.log('Error')}
    })
  }

  createBasket(){
    this.basketService.createBasket(this.createBasketRequest);
  }
}
