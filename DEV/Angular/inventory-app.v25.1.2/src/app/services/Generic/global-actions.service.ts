import { ChangeDetectorRef, Injectable } from '@angular/core';
import { GenericAPICallingService } from '../common/generic-apicalling.service';
import { Controller } from '../common/Controller';
import { API } from '../common/API';
import { Model } from '../../logic/models/Model';

@Injectable({
  providedIn: 'root',
})
export class GlobalActionsService {
  private _items: Model[] = [] as Model[];
  get Items(): Model[]{
    return this._items ?? [] as Model[];
  }
  set Items(value: Model[]){
    this._items = value;
  }

  constructor(
    private gernericApiCalling: GenericAPICallingService,
    private cdr: ChangeDetectorRef
  ) {

  }

  getData(controller: Controller, api: API) {
    this.gernericApiCalling
      .get<Model[]>(controller, api)
      .subscribe({
        next: (response) => {
          this.Items = response ?? [];
          console.log('Items fetched successfully:', this.Items);
          this.cdr.detectChanges();
        },
        error: (error) => {
          console.error('Error fetching inventory stores:', error);
        },
      });
  }
}
