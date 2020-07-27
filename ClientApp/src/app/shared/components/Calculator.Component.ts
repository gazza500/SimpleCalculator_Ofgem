import { Component } from '@angular/core';
import CalculatorService from '../api/Calculator.Service';

@Component({
  selector: 'app-calculator',
  templateUrl: 'calculator.component.html',
  styleUrls: ['calculator.component.css']  
})
export class CalculatorComponent {


  constructor(private calculatorService: CalculatorService) { }

  valuea: number;
  valueb: number;
  result: number;

  plus() {
    this.calculatorService.plus(this.valuea, this.valueb)
      .subscribe(result => this.result = result);
  }

  minus() {
    this.calculatorService.minus(this.valuea, this.valueb)
      .subscribe(result => this.result = result);
  }

  divide() {
    this.calculatorService.divide(this.valuea, this.valueb)
      .subscribe(result => this.result = result);
  }

  times() {
    this.calculatorService.times(this.valuea, this.valueb)
      .subscribe(result => this.result = result);
  }
}
