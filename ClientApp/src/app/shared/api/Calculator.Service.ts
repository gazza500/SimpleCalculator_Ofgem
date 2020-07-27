import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export default class CalculatorService {
  public API = 'http://localhost:62159';
  public CALCULATOR_API = `${this.API}/calculator`;

  constructor(private http: HttpClient) { }

  plus(numbera: number, numberb: number): Observable<number> {
    return this.http.get<number>(`${this.CALCULATOR_API}/Plus?numbera=${numbera}&numberb=${numberb}`);
  }

  minus(numbera: number, numberb: number): Observable<number> {
    return this.http.get<number>(`${this.CALCULATOR_API}/Minus?numbera=${numbera}&numberb=${numberb}`);
  }

  divide(numbera: number, numberb: number): Observable<number> {
    return this.http.get<number>(`${this.CALCULATOR_API}/Divide?numbera=${numbera}&numberb=${numberb}`);
  }

  times(numbera: number, numberb: number): Observable<number> {
    return this.http.get<number>(`${this.CALCULATOR_API}/Times?numbera=${numbera}&numberb=${numberb}`);
  }
}
