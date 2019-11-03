import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'portal';
  employee: Employee;

  constructor(private httpClient: HttpClient) { }

  ngOnInit() {
    this.httpClient.get<Employee>('http://localhost:5000/api/employees').subscribe(response => {
      this.employee = response;
    });
  }
}

class Employee {
  name: string;
  id: number;
}
