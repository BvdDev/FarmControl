import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { AnimalType } from "../../../Model/MasterData/AnimalType";
import { ServiceBase } from "../ServiceBase";

@Injectable({providedIn: 'root'})
export class AnimalTypeService extends ServiceBase<AnimalType> {
    constructor(http: HttpClient){
        super(http);
    }
}
