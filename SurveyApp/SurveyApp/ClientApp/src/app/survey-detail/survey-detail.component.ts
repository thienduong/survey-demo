import { Component, Inject, OnDestroy, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { BaseComponent } from '../base.component';
import { ActivatedRoute, Router } from '@angular/router';
//import { setTimeout } from 'timers';

@Component({
  selector: 'survey-detail',
  templateUrl: './survey-detail.component.html'
})
export class SurveyDetailComponent extends BaseComponent implements OnInit, OnDestroy {
  public frm: FormGroup;

  public controlConfig = {
    companyName: new FormControl('', [Validators.required]),
    fullName: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.required]),
    phoneNumber: new FormControl('', [Validators.required]),
    trackAndTraceModules: new FormControl(false),
    warehouseModules: new FormControl(false),
    dataAnalytics: new FormControl(false),
  };
  public formErrors = {
    companyName: '',
    fullName: '',
    email: '',
    phoneNumber: '',
  };
  public validationMessages = {
    companyName: {
      required: 'Company Name is required.'
    },
    fullName: {
      required: 'Fullname is required.'
    },
    email: {
      required: 'Email is required.'
    },
    phoneNumber: {
      required: 'Phone is required.'
    },
  };

  constructor(private _http: HttpClient, @Inject('BASE_URL') private _baseUrl: string, private _router: Router) {
    super();
  }

  ngOnInit() {
    super.ngOnInit();
  }

  save() {
    if (this.frm.invalid) {
      const errorMess = this.showFormError();
      return;
    }

    document.getElementsByClassName('cssload-container')[0].classList.remove("loaded");

    const data = Object.assign({}, this.frm.getRawValue());

    const config = new HttpHeaders().set('Content-Type', 'application/json')
      .set('Accept', 'application/json')

    this._http.post(this._baseUrl + 'api/Survey', data, { headers: config }).subscribe(result => {
      document.getElementsByClassName('cssload-container')[0].classList.add("loaded");
      this._router.navigate(['/info']);
    }, error => console.error(error));
  }

  ngOnDestroy() {
    super.ngOnInit();
  }
}


