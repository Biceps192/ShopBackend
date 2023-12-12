import { Component } from '@angular/core';
import { LoginService } from '../service/login.service';
import { LoginModel } from '../models/login.model';
import { devOnlyGuardedExpression } from '@angular/compiler';
import { UserSave } from '../models/save-user.model';
import { UserService } from '../../user/service/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  loginModel: LoginModel;
  
  constructor(private loginService: LoginService, private userService: UserService){
    this.loginModel ={
      email: '',
      password: ''
    }

  }

  onSubmit(){
    debugger;
    this.login();
  }

  login(){
    this.loginService.login(this.loginModel.email, this.loginModel.password).subscribe({
      next: (response) => {
        console.log('Login succesful')
      },
      error: (err) => {
        console.log('Error: ', err)
      }
    });
  }
}
