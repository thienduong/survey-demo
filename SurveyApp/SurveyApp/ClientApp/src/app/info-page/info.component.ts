import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'info',
  templateUrl: './info.component.html'
})
export class InfoComponent {

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
  }
}
