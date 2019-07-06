import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.scss']
})
export class AddUserComponent implements OnInit {

  public addUser = new addUser();
  public addUserHeader: string = 'Add User';
  constructor() {
    this.addUserHeader = 'Add User';
  }

  ngOnInit() {
    this.addUserHeader = 'Add User';
  }

  elements: any = [
    { id: 1, first: 'Mark', last: 'Otto', handle: '@mdo' },
    { id: 2, first: 'Jacob', last: 'Thornton', handle: '@fat' },
    { id: 3, first: 'Larry', last: 'the Bird', handle: '@twitter' },
  ];

  headers = ['Employee Id', 'First Name', 'Last Name', '#'];
  
  addUserCall()
  {

  }
  sortUser(sortBy: string) {

  }

  editUser() {
    this.addUserHeader = 'Update User';
  }

  deleteUser() {

  }

  reset() {
    this.addUserHeader = 'Add User';
  }


}

export class addUser {
  public Id: number;
  public FirstName: string;
  public LastName: string;
  public EmployeeId: string;
}
