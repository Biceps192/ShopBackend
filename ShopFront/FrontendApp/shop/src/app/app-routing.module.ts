import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './core/components/home/home.component';
import { CategoriesListComponent } from './features/category/categories-list/categories-list.component';
import { RegistrationComponent } from './features/registration/registration/registration.component';
import { ProductsComponent } from './features/products/products/products.component';
import { BasketComponent } from './features/basket/basket/basket.component';
import { OrderComponent } from './features/order/order/order.component';
import { SubcategoryComponent } from './features/category/subcategory/subcategory.component';
import { TypageComponent } from './features/order/typage/typage.component';
import { LoginComponent } from './features/login/login/login.component';
import { FavouritesComponent } from './features/favourites/favourites/favourites.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'categories', component: CategoriesListComponent},
  {path: 'registration', component: RegistrationComponent},
  {path: 'categories/:id', component: ProductsComponent},
  {path: 'basket', component: BasketComponent},
  {path: 'order', component: OrderComponent},
  {path: 'subcategory/:id', component: SubcategoryComponent},
  {path: 'tyfororder', component: TypageComponent},
  {path: 'login', component: LoginComponent},
  {path: 'favourites', component: FavouritesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
