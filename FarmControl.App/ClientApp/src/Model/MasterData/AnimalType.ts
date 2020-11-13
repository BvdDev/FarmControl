import { Entity } from "../Entity";

export class AnimalType extends Entity {
  Name: string;
  Code: string;
  Created: Date;

  constructor(name: string, code: string, created: Date) {
    super();
    this.Name = name;
    this.Code = code;
    this.Created = created;
  }
}
