import { Entity } from "../Entity";

export class AnimalType extends Entity {
  Name: string;
  Code: string;
  Created: Date;

  constructor(name: string, code: string) {
    super();
    this.Name = name;
    this.Code = code;
  }
}
