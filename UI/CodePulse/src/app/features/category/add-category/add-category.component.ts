import { Component, OnDestroy } from '@angular/core';
import { AddCategoryRequest } from '../models/add-category-request';
import { CategoryService } from '../services/category.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrls: ['./add-category.component.scss'],
})
export class AddCategoryComponent implements OnDestroy {
  model: AddCategoryRequest;

  private addCategorySubscribtion?: Subscription;

  constructor(private categoryService: CategoryService) {
    this.model = {
      name: '',
      urlHandle: '',
    };
  }

  onFormSubmit() {
    this.addCategorySubscribtion = this.categoryService
      .addCategory(this.model)
      .subscribe({
        next: (response) => {
          console.log('this was successfull');
        },
        error: (error) => {
          console.log('There was error');
        },
      });
  }
  ngOnDestroy(): void {
    this.addCategorySubscribtion?.unsubscribe;
  }
}
