import { ChangeDetectorRef, Injectable } from '@angular/core';
import { GenericAPICallingService } from '../common/generic-apicalling.service';
import { Controller } from '../common/Controller';
import { API } from '../common/API';
import { Model } from '../../logic/models/Model';
import { Observable } from 'rxjs';
import { Application } from './Application';
import { TranslateBL } from './translate/TranslateBL';
import { AsideSectionCollection } from '../../core/common/aside-nav-bar/aside-section/AsideSectionCollection';

@Injectable({
  providedIn: 'root',
})
export class GlobalActionsService {
  private _DataItemsLoaded: Model[] = [] as Model[];
  get DataItemsLoaded(): Model[]{
    return this._DataItemsLoaded ?? [] as Model[];
  }
  set DataItemsLoaded(value: Model[]){
    this._DataItemsLoaded = value;
  }

  private _application: Application = {} as Application;
  get Application(): Application {
    return this._application;
  }
  set Application(value: Application) {
    this._application = value;
    switch (value) {
      case Application.InventoryCategoryList:
        this.Controller = Controller.InventoryCategory;
        this.API = API.GetAllIsOnDuty;
        break;
    }
  }

  private _controller: Controller = {} as Controller;
  get Controller(): Controller {
    return this._controller;
  }
  set Controller(value: Controller) {
    this._controller = value;
  }

  private _api: API = {} as API;
  get API(): API {
    return this._api;
  }
  set API(value: API) {
    this._api = value;
  }

  private _traslatedBL: TranslateBL = {} as TranslateBL;
  get TranslateBL(): TranslateBL{
    return this._traslatedBL;
  }
  set TranslateBL(value: TranslateBL){
    this._traslatedBL = value;
  }

  private _asideItems: AsideSectionCollection[] = [] as AsideSectionCollection[];
  get AsideItems(): AsideSectionCollection[]{
    return this._asideItems;
  }
  set AsideItems(value: AsideSectionCollection[]){
    this._asideItems = value;
  }

  constructor(
    private gernericApiCalling: GenericAPICallingService
  ) {

  }

  getData(controller: Controller, api: API): Observable<Model[]> {
    return this.gernericApiCalling.get<Model[]>(controller, api);
  }

  setApplication(controller: Controller, api: API, application: Application, translatedItems: TranslateBL){
    this.Controller = controller;
    this.API = api;
    this.Application = application;
    this.TranslateBL = translatedItems;
  }

  setAsideNavBarItems(){
    
  }
}
