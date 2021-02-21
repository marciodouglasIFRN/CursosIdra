import { Component, OnInit } from '@angular/core';
import { Cartao } from '../Cartao';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-cartao-form',
  templateUrl: './cartao-form.component.html',
  styleUrls: ['./cartao-form.component.css']
})
export class CartaoFormComponent{

  profileForm = new FormGroup({
    firstName: new FormControl(''),
    lastName: new FormControl(''),
  });

}
