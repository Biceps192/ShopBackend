import { Component, EventEmitter, Input, Output} from '@angular/core'
import { PageEvent } from '@angular/material/paginator';

@Component({
  selector: 'app-paginator',
  templateUrl: './paginator.component.html',
  styleUrls: ['./paginator.component.css']
})
export class PaginatorComponent {
  currentPage = 1;

  handlePageEvent(pageEvent: PageEvent){
    console.log("Page information", pageEvent)
  }
}
