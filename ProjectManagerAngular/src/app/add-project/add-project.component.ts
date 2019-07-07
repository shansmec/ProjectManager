import { Component, OnInit } from '@angular/core';
import { Options } from 'ng5-slider';


@Component({
  selector: 'app-add-project',
  templateUrl: './add-project.component.html',
  styleUrls: ['./add-project.component.scss']
})
export class AddProjectComponent implements OnInit {
  public addProjectHeader: string ='Add Project'; 
  public chkStartEndDate: boolean = true;;
  constructor() { }
  public project: Project = new Project();
  options: Options = {
    floor: 0,
    ceil: 30
  };
  ngOnInit() {
    this.addProjectHeader='Add Project'
  }
  reset()
  {
    this.addProjectHeader='Add Project'
  }

}

export class Project
{
  public projectName: string;
  public startDate: Date;
  public endDate: Date;
  public priority: number=0;
  public managerName: string;
}
