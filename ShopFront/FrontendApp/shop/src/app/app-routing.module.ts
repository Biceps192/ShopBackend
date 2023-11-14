import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './core/components/home/home.component';
import { CategoriesListComponent } from './features/category/categories-list/categories-list.component';
import { RegistrationComponent } from './features/registration/registration/registration.component';
import { ProductsComponent } from './features/products/products/products.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'categories', component: CategoriesListComponent},
  {path: 'registration', component: RegistrationComponent},
  {path: 'categories/:id', component: ProductsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
