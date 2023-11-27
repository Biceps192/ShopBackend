import { Component, OnInit } from '@angular/core';
import { UserService } from '../service/user.service';
import { AddPublicUserRequest } from '../models/user-request.model';
import { CreateBasketRequest } from '../../basket/models/create-basket.model';
import { BasketService } from '../../basket/service/basket.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
  model: AddPublicUserRequest;
  createBasketRequest: CreateBasketRequest;
  publicUserData: any = [];

  constructor(private publicUserService: UserService, private basketService: BasketService){
    this.model = {
      firstName: '',
      lastName: '',
      email: '',
      phoneNumber: ''
    }

    this.createBasketRequest = {
      publicUserId: 0,
      basketId: 0
    }
  }
  ngOnInit(): void {
    const saveData = this.publicUserService.getUserData();
    console.log('Saved data: ', saveData);
    if(saveData){
      this.publicUserData = saveData;
    }
  }



  onSubmit(){
    this.publicUserService.addPublicUser(this.model).subscribe({
      next: (response) => {
        console.log('User Add')
        this.savePublicUserData();
        this.createBasketRequest.publicUserId = response.id;
        this.basketService.createBasket(this.createBasketRequest).subscribe({
          next: (response) =>{
            this.createBasketRequest.basketId = response.id;
            this.saveBasket();
            console.log('Basket created');
          },
          error: (error) =>{
            console.error('Error');
          }
        })
      },
      error: (err) => {console.log('Error')}
    })
  }

  savePublicUserData(){
    this.publicUserService.saveUserData(this.model);
  }

  saveBasket(){
    this.basketService.saveBasket(this.createBasketRequest);
  }

}
