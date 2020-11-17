import { Component, OnInit } from '@angular/core';
import { AnimalType } from '../../Model/MasterData/AnimalType';
import { AnimalTypeService } from '../../Model/Services/MasterData/AnimalType.service';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent implements OnInit {
  public animalTypes: AnimalType[] = [];

  constructor (private animalTypeService: AnimalTypeService) {  }

  ngOnInit() {
    this.getAnimalTypes();
  }

  private getAnimalTypes(): void {
    this.animalTypeService.GetAll().subscribe(x => this.animalTypes = x);
  }

  public onClick(){
    var newAnimalType = new AnimalType("Chicker", "03");

    this.animalTypeService.Add(newAnimalType);
  }
}
