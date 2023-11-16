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
      publicUserId: 0
    }
  }
  ngOnInit(): void {
    const saveData = this.publicUserService.getUserData();
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
        console.log('Public User Id: ', this.createBasketRequest.publicUserId); 
        this.basketService.createBasket(this.createBasketRequest).subscribe({
          next: (response) =>{
            console.log('Basket created');
            debugger;
            this.basketService.setBasketStatus(true);
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
    debugger;
    this.publicUserService.saveUserData(this.publicUserData);
  }

}
