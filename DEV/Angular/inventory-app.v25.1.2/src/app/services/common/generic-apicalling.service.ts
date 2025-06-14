import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Controller } from './Controller';
import { Observable } from 'rxjs';
import { API } from './API';

@Injectable({
  providedIn: 'root'
})
export class GenericAPICallingService {
  private baseURL: string = 'https://localhost:7272/';

  constructor(private http: HttpClient) { }

   get<T>(controller: Controller, api: API, params?: { [key: string]: any }): Observable<T> {
    console.log('GenericAPICallingService.get called with:', controller, api, params);
    let url = this.baseURL + controller + '/' + api;
    if (params) {
      const query = new URLSearchParams(params).toString();
      url += `?${query}`;
    }
    return this.http.get<T>(url);
  }
}
