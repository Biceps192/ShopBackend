import { Component } from '@angular/core';
import { AddUserRequest } from '../models/add-user-request.model';
import { RegistrationService } from '../services/registration.service';
import { UserService } from '../../user/service/user.service';
import { UserSave } from '../../login/models/save-user.model';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent {
  
  model: AddUserRequest;

  constructor(private registrationService: RegistrationService){
    this.model = {
      username: '',
      email: '',
      password: ''
    }
  }

  onSubmit(){
    this.registrationService.addUser(this.model).subscribe({
      next: (response) => {
        console.log('Success')
      },
      error: (err) => {
        console.log('Error')
      }
    });
  }
}
