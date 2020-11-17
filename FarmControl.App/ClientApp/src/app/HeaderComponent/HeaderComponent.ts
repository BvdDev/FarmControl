import { Component } from '@angular/core';

@Component({
  selector: 'Header',
  templateUrl: './HeaderComponent.html',
  styleUrls: ['./HeaderComponent.css']
})
export class HeaderComponent {
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
