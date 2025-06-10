import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Controller } from './Controller';
import { Observable } from 'rxjs';
import { API } from './API';

@Injectable({
  providedIn: 'root'
})
export class GenericAPICallingService {

  private patientPortalBaseURL: string = 'https://localhost:7090/';

  constructor(private http: HttpClient) { }

   get<T>(controller: Controller, api: API, params?: { [key: string]: any }): Observable<T> {
    let url = this.patientPortalBaseURL + controller + '/' + api;
    if (params) {
      const query = new URLSearchParams(params).toString();
      url += `?${query}`;
    }
    return this.http.get<T>(url);
  }
}
