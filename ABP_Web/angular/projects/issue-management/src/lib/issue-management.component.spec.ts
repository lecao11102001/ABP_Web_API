import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { IssueManagementComponent } from './components/issue-management.component';
import { IssueManagementService } from '@acme/issue-management';
import { of } from 'rxjs';

describe('IssueManagementComponent', () => {
  let component: IssueManagementComponent;
  let fixture: ComponentFixture<IssueManagementComponent>;
  const mockIssueManagementService = jasmine.createSpyObj('IssueManagementService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [IssueManagementComponent],
      providers: [
        {
          provide: IssueManagementService,
          useValue: mockIssueManagementService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(IssueManagementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
