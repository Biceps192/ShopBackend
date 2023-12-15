import { NgModule } from '@angular/core';
import { CarouselModule } from 'ngx-owl-carousel-o';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './core/components/navbar/navbar.component';
import { HomeComponent } from './core/components/home/home.component';
import { FooterComponent } from './core/components/footer/footer.component';
import { FormsModule } from '@angular/forms';
import { CategoriesListComponent } from './features/category/categories-list/categories-list.component';
import {HttpClientModule} from '@angular/common/http';
import { RegistrationComponent } from './features/registration/registration/registration.component'
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ProductsComponent } from './features/products/products/products.component';
import { CarouselComponent } from './features/carousel/carousel/carousel.component';
import { BasketComponent } from './features/basket/basket/basket.component';
import { UserComponent } from './features/user/user/user.component';
import { OrderComponent } from './features/order/order/order.component';
import { SubcategoryComponent } from './features/category/subcategory/subcategory.component';
import { PaginatorComponent } from './features/paginator/paginator/paginator.component';
import { AngularPaginatorModule } from 'angular-paginator';
import { TypageComponent } from './features/order/typage/typage.component';
import { LoginComponent } from './features/login/login/login.component';
import { FavouritesComponent } from './features/favourites/favourites/favourites.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatPaginatorModule} from '@angular/material/paginator';
import { AllproductsComponent } from './features/products/allproducts/allproducts.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HomeComponent,
    FooterComponent,
    RegistrationComponent,
    CategoriesListComponent,
    RegistrationComponent,
    ProductsComponent,
    CarouselComponent,
    BasketComponent,
    UserComponent,
    OrderComponent,
    SubcategoryComponent,
    PaginatorComponent,
    TypageComponent,
    LoginComponent,
    FavouritesComponent,
    AllproductsComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    BsDropdownModule,
    AngularPaginatorModule,
    CarouselModule,
    BrowserAnimationsModule,
    MatPaginatorModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
