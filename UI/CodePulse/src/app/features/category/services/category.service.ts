import { Injectable } from '@angular/core';
import { AddCategoryRequest } from '../models/add-category-request';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class CategoryService {
  apiBaseUrl: string = 'https://localhost:7190/api';
  constructor(private http: HttpClient) {}

  addCategory(model: AddCategoryRequest): Observable<void> {
    return this.http.post<void>(`${this.apiBaseUrl}/category`, model);
  }
}
