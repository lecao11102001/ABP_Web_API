import { TestBed } from '@angular/core/testing';
import { IssueManagementService } from './services/issue-management.service';
import { RestService } from '@abp/ng.core';

describe('IssueManagementService', () => {
  let service: IssueManagementService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(IssueManagementService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
