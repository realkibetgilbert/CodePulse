import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../services/category.service';
import { Category } from '../models/category';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.scss'],
})
export class CategoryListComponent implements OnInit {
  //categories?: Category[] = [];
  categories$?: Observable<Category[]>;

  constructor(private categoryService: CategoryService) {}
  ngOnInit(): void {
    this.getAllCategories();
  }

  getAllCategories() {
    this.categories$ = this.categoryService.getAllCategories();
  }

}
