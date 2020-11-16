import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { AnimalType } from '../../Model/MasterData/AnimalType';
import { AnimalTypeService } from '../../Model/Services/MasterData/AnimalType.service';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent implements OnInit {
  public animalTypes: AnimalType[] = [];

  constructor (private http: HttpClient) {  }

  ngOnInit() {
    this.getAnimalTypes();
  }

  private getAnimalTypes(): void {
    new AnimalTypeService(this.http).GetAll().subscribe(x => this.animalTypes = x);
  }

  public onClick(){
    var newAnimalType = new AnimalType("Chicker", "03");

    new AnimalTypeService(this.http).Add(newAnimalType);
  }
}
