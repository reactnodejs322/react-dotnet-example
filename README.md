nginx: Reverse Proxy version => latest
Client: React version => 17.0.1
users: .NetCore version => 5

## Common deploy issues

Error: Error creating IAM Role terraform-20210613171749996800000001: AccessDenied: User: arn:aws:iam::642815940637:user/terraform is not authorized to perform: iam:CreateRole on resource: arn:aws:iam::642815940637:role/terraform-20210613171749996800000001 with an explicit deny
status code: 403, request id: 4390670f-576b-40fa-a209-7c85ac3c9648

Create a new aws user with admin and billing permission

add this role for safety

````
{
    "Version": "2012-10-17",
    "Statement": [
        {
            "Effect": "Allow",
            "Action": [
                "iam:CreateRole",
                "iam:DeleteRole",
                "iam:DeleteRolePolicy",
                "iam:ListRolePolicies",
                "iam:ListRoles",
                "iam:PutRolePolicy"
            ],
            "Resource": [
                "*"
            ]
        }
    ]
}```

````
