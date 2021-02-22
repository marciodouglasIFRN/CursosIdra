import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-cartao-form',
  templateUrl: './cartao-form.component.html',
  styleUrls: ['./cartao-form.component.css']
})
export class CartaoFormComponent{
  public form: FormGroup;
  constructor() {
    this.form = new FormBuilder().group({
      name: '',
      address: ''
    });
  }

}
